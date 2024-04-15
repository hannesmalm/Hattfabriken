using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Hattfabriken.Models;
using static NuGet.Packaging.PackagingConstants;
using System.Net.Mail;
using System.Net;

namespace Hattfabriken.Controllers
{
    public class MaterialController : Controller
    {
        private readonly HatDbContext _dbContext;

        public MaterialController(HatDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var materials = _dbContext.Materials.ToList();
            return View(materials);
        }

        public IActionResult StorageOfMaterials()
        {
            var materials = _dbContext.Materials.ToList();
            return View("~/Views/Lager/StorageOfMaterials.cshtml", materials);
        }

        public IActionResult Orders()
        {
            var materials = _dbContext.Materials.ToList();
            ViewData["Materials"] = materials;
            var requests = _dbContext.QuantityRequests.ToList();
            return View("~/Views/Lager/Orders.cshtml", requests);
        }


        [HttpPost]
        public IActionResult AddMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Materials.Add(material);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(StorageOfMaterials));
            }
            return View(material);
        }

        public IActionResult EditMaterial(string id)
        {
            var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == id);
            if (material == null)
            {
                return NotFound();
            }
            return View("~/Views/Lager/EditMaterial.cshtml", material);
        }

        [HttpPost]
        public IActionResult EditMaterial(Material material)
        {
            if (ModelState.IsValid)
            {
                _dbContext.Materials.Update(material);
                _dbContext.SaveChanges();
                return RedirectToAction(nameof(StorageOfMaterials));
            }
            return View(material);
        }


        [HttpPost]
        public IActionResult OrderMaterial(string MaterialName, int Quantity)
        {
            var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == MaterialName);
            if (material != null)
            {
                material.MaterialQuantity += Quantity;
                _dbContext.SaveChanges();
            }
            return RedirectToAction(nameof(Orders)); // Ensure this redirects to the Orders action
        }


        [HttpPost]
        public IActionResult ConfirmDelivery()
        {
            // Get all quantity requests that are not yet confirmed
            var requests = _dbContext.QuantityRequests.Where(r => !r.IsConfirmed).ToList();

            foreach (var request in requests)
            {
                // Mark the request as confirmed
                request.IsConfirmed = true;

                // Update the material quantity in the database
                var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == request.MaterialName);
                if (material != null)
                {
                    material.MaterialQuantity += request.RequestedQuantity;
                }
            }

            // Save changes to the database
            _dbContext.SaveChanges();

            // Redirect back to the Orders action
            return RedirectToAction(nameof(Orders));
        }



        //[HttpPost]
        //public IActionResult RequestQuantity(string MaterialName, int Quantity)
        //{
        //    // Find the material based on the material name
        //    var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == MaterialName);
        //    if (material != null)
        //    {
        //        // Create a new quantity request associated with the material
        //        var request = new QuantityRequest
        //        {
        //            MaterialName = MaterialName,
        //            RequestedQuantity = Quantity,
        //            IsConfirmed = false,
        //            Material = material // Associate the quantity request with the material
        //        };

        //        // Add the request to the database
        //        _dbContext.QuantityRequests.Add(request);
        //        _dbContext.SaveChanges();
        //    }

        //    // Redirect back to the Orders action
        //    return RedirectToAction(nameof(Orders));
        //}


        [HttpPost]
        public IActionResult RequestQuantity(string MaterialName, int Quantity)
        {
            // Find the material based on the material name
            var material = _dbContext.Materials.FirstOrDefault(m => m.MaterialName == MaterialName);
            if (material != null)
            {
                // Create a new quantity request associated with the material
                var request = new QuantityRequest
                {
                    MaterialName = MaterialName,
                    RequestedQuantity = Quantity,
                    IsConfirmed = false,
                    Material = material // Associate the quantity request with the material
                };

                // Add the request to the database
                _dbContext.QuantityRequests.Add(request);
                _dbContext.SaveChanges();

                // Generate the email body
                var emailBody = $"Dear {material.MaterialSupplier},\n\n" +
                                $"I would like to request {Quantity} units of {MaterialName}.\n\n" +
                                "Best regards,\n[Your Name]";

                // Generate the mailto link
                var mailtoLink = $"mailto:{material.MaterialSupplier}?subject=Material Request&body={Uri.EscapeDataString(emailBody)}";

                // Redirect the user to the mailto link
                return Redirect(mailtoLink);
            }

            // Redirect back to the Orders action
            return RedirectToAction(nameof(Orders));
        }




        // :3


        [HttpPost]
        public IActionResult ConfirmSelectedRequests(List<int> selectedRequests)
        {
            if (selectedRequests != null && selectedRequests.Any())
            {
                var requestsToConfirm = _dbContext.QuantityRequests
                    .Include(r => r.Material) // Include Material to avoid lazy loading
                    .Where(r => selectedRequests.Contains(r.Id) && !r.IsConfirmed)
                    .ToList();

                foreach (var request in requestsToConfirm)
                {
                    request.IsConfirmed = true;
                    request.Material.MaterialQuantity += request.RequestedQuantity; // Update MaterialQuantity
                }

                _dbContext.SaveChanges();
            }

            return RedirectToAction(nameof(Orders));
        }










    }
}
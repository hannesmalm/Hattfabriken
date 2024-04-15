function updatePrice() {
    var hatType = document.getElementById("HatId");
    var hatTypePrice = 0;

    // Update the hat type price based on the selected option
    if (hatType.value === "1") {
        hatTypePrice = 50; // Cowboy hat price
    } else if (hatType.value === "2") {
        hatTypePrice = 40; // Sheriff hat price
    } else if (hatType.value === "3") {
        hatTypePrice = 60; // Peaky Blinders hat price
    }

    // Get the selected material price
    var material = document.getElementById("Material");
    var materialPrice = parseFloat(material.options[material.selectedIndex].text.split('-')[1]);

    // Get the selected special effects and their prices
    var selectedSpecialEffects = document.getElementsByName("SelectedSpecialEffekter");
    var specialEffectsPrice = 0;
    for (var i = 0; i < selectedSpecialEffects.length; i++) {
        if (selectedSpecialEffects[i].checked) {
            if (selectedSpecialEffects[i].value === "Feather") {
                specialEffectsPrice += 10;
            } else if (selectedSpecialEffects[i].value === "Lace") {
                specialEffectsPrice += 8;
            } else if (selectedSpecialEffects[i].value === "Pearls") {
                specialEffectsPrice += 12;
            } else if (selectedSpecialEffects[i].value === "Flower") {
                specialEffectsPrice += 15;
            }
        }
    }

    // Calculate the total price
    var totalPrice = hatTypePrice + materialPrice + specialEffectsPrice;

    // Display the estimated price
    var estimatedPriceElement = document.getElementById("estimatedPrice");
    estimatedPriceElement.innerHTML = totalPrice + " SEK";

    // Update hidden fields for hat type price and material price
    document.getElementById("HatTypePrice").value = hatTypePrice;
    document.getElementById("MaterialPrice").value = materialPrice;
}

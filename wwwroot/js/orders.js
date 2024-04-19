// Antag att orders-arrayen är deklarerad och initialiserad korrekt tidigare i koden.

function updateOrderStatus(orderId, newStatus) {
    // Använda AJAX för att skicka en förfrågan till servern för att uppdatera orderns status
    $.ajax({
        url: '/Orders/UpdateStatus', // URL till action-metoden i din OrdersController
        method: 'POST',
        data: { id: orderId, status: newStatus },
        success: function (response) {
            // Hantera ett framgångsrikt svar
            console.log('Order status updated successfully!');
        },
        error: function (xhr) {
            // Hantera fel
            console.error('Error updating order status: ' + xhr.responseText);
        }
    });
}

function allowDrop(ev) {
    ev.preventDefault();
    if (ev.target.classList.contains('kanban-column')) {
        ev.target.classList.add('drag-over');
    }
}

function drag(ev) {
    ev.dataTransfer.setData("text/plain", ev.target.id);
}

function drop(ev) {
    ev.preventDefault();
    var data = ev.dataTransfer.getData("text");
    var draggableElement = document.getElementById(data);
    var newStatus = ev.target.id.replace('kanban-column-', ''); // Anta att kolumnens id är 'kanban-column-STATUS'

    if (ev.target.classList.contains('kanban-column')) {
        ev.target.appendChild(draggableElement);
    } else {
        ev.target.closest('.kanban-column').appendChild(draggableElement);
    }

    var oldStatus = draggableElement.getAttribute('data-status');
    if (newStatus !== oldStatus) {
        draggableElement.setAttribute('data-status', newStatus);
        var orderId = data.split('-')[1]; // Anta att id är det andra elementet efter split
        updateOrderStatus(orderId, newStatus);
    }
}

document.querySelectorAll('.kanban-column').forEach(function (column) {
    column.addEventListener('dragover', allowDrop);
    column.addEventListener('drop', drop);
    column.addEventListener('dragleave', function (ev) {
        if (ev.target.classList.contains('kanban-column')) {
            ev.target.classList.remove('drag-over');
        }
    });
});
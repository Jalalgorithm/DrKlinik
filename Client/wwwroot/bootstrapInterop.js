window.bootstrapInterop = {
    showModal: function (modalId) {
        var myModal = new bootstrap.Modal(document.getElementById(modalId));
        myModal.show();
    }
};

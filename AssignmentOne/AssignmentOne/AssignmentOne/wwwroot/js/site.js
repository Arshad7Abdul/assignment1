
const select = $('#state-dropdown');
$(document).ready(() => {

    // Fetch the list of states from the C# controller
    $.ajax({
        url: '/State/GetStates', // Replace with the actual URL of your C# method
        type: 'GET',
        dataType: 'json',
        success: function (states) {
            // Populate the dropdown with the retrieved states
            $.each(states, function (index, state) {
                $('#state-dropdown').append($('<option></option>').val(state.Value).text(state.Text));
            });
        },
        error: function (xhr, textStatus, errorThrown) {
            // Handle the error
            alert('An error occurred while retrieving the states.');
        }
    });
});
$('input[type=button][data-validate=true]').click(
    function () {
        var form = $(this).parent('form');
        var input = $('input[type=number]', form);
        if (Number(input.val()) <= 0) {
            alert('Quantity should be greater than 0.');
        } else {
            form.submit();
        }
    }
);
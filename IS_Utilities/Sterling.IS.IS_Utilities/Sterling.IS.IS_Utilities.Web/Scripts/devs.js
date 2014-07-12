$(function () {
   $('.imgDev').imagefit({
	    mode: 'inside',
	    force : 'true',
	    halign : 'center',
	    valign : 'top'
    });
    $('.dev-list').click(function () {
        var url = $(this).attr('data-action');
        if (url !== undefined)
            window.location.href = url;
    });
    $('.editDev_icon').click(function () {

        var id = $(this).attr('data-id');
        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: '/Developers/_Edit/' + id,
                success: function (result) {

                    $("#devEditForm").html(result);
                    $('#devEditForm').dialog({
                        modal: true,
                        width: '600px'
                    });
                },

                error: function (error) {
                    alert('Fail');
                }
            });

        return false;
    });
    $('.deleteDev_icon').click(function () {

        var id = $(this).attr('data-id');
        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: '/Developers/_Delete/' + id,
                success: function (result) {

                    $("#devDeleteForm").html(result);
                    $('#devDeleteForm').dialog({
                        modal: true,
                        width: '600px'
                    });
                },

                error: function (error) {
                    alert('Fail');
                }
            });

        return false;
    });
    $('#createDevBtn').click(function () {


        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: '/Developers/_CreateDev',
                success: function (result) {

                    $('#devCreateForm textarea').val('');
                    $('#devCreateForm input[type=text]').val('');
                    $('#devCreateForm').show();
                    $("#devCreateForm").html(result);
                    $('#devCreateForm').dialog({

                        modal: true,
                        width: '600px'
                    });
                },

                error: function (error) {
                    alert('Fail');
                }
            });



    });
});
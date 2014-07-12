$(function () {
    $('.home-appList').click(function () {
        var url = $(this).attr('data-action');
        if (url !== undefined)
            window.location.href = url;
    });
    $('.editApp_icon').click(function () {
        var id = $(this).attr('data-id');
        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: 'App/_Edit/' + id,
                success: function (result) {

                    $("#editForm").html(result);
                    $('#editForm').dialog({
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
    $('.deleteApp_icon').click(function () {
        var id = $(this).attr('data-id');
        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: 'App/_Delete/' + id,
                success: function (result) {

                    $("#deleteForm").html(result);
                    $('#deleteForm').dialog({
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
    //    $('#app-create-new span').click(function () {
    //        $('#AppForm textarea').val('');
    //        $('#AppForm input[type=text]').val('');
    //        $('#AppForm').show();
    //        $('#AppForm').dialog({

    //            modal: true,
    //            width: '600px'
    //        });


    //    });


    $('#app-create-new span').click(function () {

        $.ajax(
            {
                type: 'POST',
                dataType: 'html',
                url: '/App/_Create',
                success: function (result) {

                    $('#AppForm textarea').val('');
                    $('#AppForm input[type=text]').val('');
                    $('#AppForm').show();
                    $("#AppForm").html(result);
                    $('#AppForm').dialog({

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
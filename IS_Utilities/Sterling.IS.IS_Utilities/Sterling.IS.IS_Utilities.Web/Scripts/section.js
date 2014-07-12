$(function () {

    $('#createSection').click(function () {
        $("#sectionCreateForm").slideUp('slow');
    });
    $('#createSectionBtn').click(function () {
        $("#sectionCreateForm").slideToggle('slow');

    });
    $('.deleteSection_icon').click(function () {
        
        var id = $(this).attr('data-id');
        $.ajax(
                    {
                        type: 'POST',
                        dataType: 'html',
                        url: '/Section/_Delete/' + id,
                        success: function (result) {

                            $("#sectionDeleteForm").html(result);
                            $('#sectionDeleteForm').dialog({
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
    $('.editSection_icon').click(function () {
        var url = $(this).attr('data-action');
        if (url !== undefined)
            window.location.href = url;

    });
});
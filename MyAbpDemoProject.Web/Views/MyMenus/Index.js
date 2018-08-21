(function () {
    $(function () {

        var _myMenuService = abp.services.app.menu;
        var _$modal = $('#MyMenuCreateModal');
        var _$form = _$modal.find('form');

        _$form.validate({
            rules: {
            }
        });

        $('#RefreshButton').click(function () {
            refreshMyMenuList();
        });

        $('.delete-mymenu').click(function () {
            var myMenuId = $(this).attr("data-mymenu-id");
            var myMenuName = $(this).attr('data-mymenu-name');

            deleteMyMenu(myMenuId, myMenuName);
        });

        $('.edit-mymenu').click(function (e) {
            var myMenuId = $(this).attr("data-mymenu-id");

            $('#MyMenuEditModal div.modal-content').html('');
            e.preventDefault();
            $.ajax({
                url: abp.appPath + 'MyMenus/EditMyMenuModal?myMenuId=' + myMenuId,
                type: 'POST',
                contentType: 'application/html',
                success: function (content) {
                    $('#MyMenuEditModal div.modal-content').html(content);
                },
                error: function (e) { }
            });
        });

        _$form.find('button[type="submit"]').click(function (e) {
            e.preventDefault();

            if (!_$form.valid()) {
                return;
            }

            var myMenu = _$form.serializeFormToObject(); //serializeFormToObject is defined in main.js

            abp.ui.setBusy(_$modal);
            _myMenuService.insertMyMenu(myMenu).done(function () {
                _$modal.modal('hide');
                location.reload(true); //reload page to see new myMenu!
            }).always(function () {
                abp.ui.clearBusy(_$modal);
            });
        });

        _$modal.on('shown.bs.modal', function () {
            _$modal.find('input:not([type=hidden]):first').focus();
        });

        function refreshMyMenuList() {
            location.reload(true); //reload page to see new myMenu!
        }

        function deleteMyMenu(myMenuId, myMenuName) {
            abp.message.confirm(
                "删除菜品 - '" + myMenuName + "'?",
                function (isConfirmed) {
                    if (isConfirmed) {
                        _myMenuService.deleteMyMenu({
                            id: myMenuId
                        }).done(function () {
                            refreshMyMenuList();
                        });
                    }
                }
            );
        }
    });
})();
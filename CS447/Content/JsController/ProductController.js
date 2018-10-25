var product = {
    init: function () {
        product.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('id');
            $.ajax({
                url: "/Admin/Product/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.status == true) {
                        btn.text('Kích hoạt');
                    }
                    else {
                        btn.text('Khóa');
                    }
                }
            }
            );
        });
    }
}
product.init();

var productshowon = {
    init: function () {
        productshowon.registerEvents();
    },
    registerEvents: function () {
        $('.btn-active-showon').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('showid');
            $.ajax({
                url: "/Admin/Product/ChangeShowOn",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.showon == true) {
                        btn.text('Bật');
                    }
                    else {
                        btn.text('Tắt');
                    }
                }
            }
            );
        });
    }
}
productshowon.init();

var slide = {
    init: function () {
        slide.registerEvents();
    },
    registerEvents: function () {
        $('.btn-slide').off('click').on('click', function (e) {
            e.preventDefault();
            var btn = $(this);
            var id = btn.data('slideid');
            $.ajax({
                url: "/Admin/Slides/ChangeStatus",
                data: { id: id },
                dataType: "json",
                type: "POST",
                success: function (response) {
                    if (response.status == true) {
                        btn.text('Kích hoạt');
                    }
                    else {
                        btn.text('Tắt');
                    }
                }
            }
            );
        });
    }
}
slide.init();
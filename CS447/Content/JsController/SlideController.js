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
                url: "/Admin/Slides/ChangeStatus1",
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
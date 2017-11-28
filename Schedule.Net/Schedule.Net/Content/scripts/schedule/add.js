layui.use(['form', 'layer', 'jquery', 'layedit', 'laydate'], function () {
    var $ = layui.$;
    var layer = layui.layer;
    var form = layui.form;
    var layedit = layui.layedit;
    var laydate = layui.laydate;

    form.on("submit(addTask)", function (data) {
        var index;
        $.ajax({
            url: "/Schedule/AddTask",
            type: "POST",
            contentType: "application/json",
            dataType: "json",
            data: JSON.stringify(data.field),
            beforeSend: function() {
                index = layer.msg('数据提交中，请稍候', { icon: 16, time: false, shade: 0.8 });
            },
            success: function (result) {
                layer.close(index);
                layer.msg("任务新增成功！");
                layer.closeAll("iframe");
                parent.location.reload();
                console.log(result);
            }
        });
        return false;
    });

});
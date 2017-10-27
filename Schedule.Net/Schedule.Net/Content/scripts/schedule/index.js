layui.use(['table'], function () {
    var table = layui.table;

    table.render({
        //设定容器唯一ID
        id: 'idTest',
        //指定原始表格元素选择器（推荐id选择器）
        elem: '#schedule', 
        //容器高度
        //height: 315,
        //设置表头
        cols: [[
            { field: 'Name', title: '任务名称', width: 200 },
            { field: 'Desc', title: '任务描述', width: 200 },
            { field: 'Remark', title: '备注', width: 200 },
            { field: 'StrCreateDate', title: '创建时间', width: 200 },
            { fixed: 'right', width: 250, align: 'center', toolbar: '#scheduleBar' },
        ]], 

        //接口地址
        url: '/Schedule/GetList',                    
        //接口http请求类型
        method: 'get',              
        //接口的其它参数
        //where: {
            
        //},                          
        //用于对分页请求的参数：page、limit重新设定名称
        request: {
            pageName: 'pageIndex',       //页码的参数名称，默认：page
            limitName: 'pageSize',       //每页数据量的参数名，默认：limit
        },                          
        //用于对返回的数据格式的自定义
        response: {
            statusName: 'code',     //数据状态的字段名称，默认：code
            statusCode: 0,          //成功的状态码，默认：0
            msgName: 'msg',         //状态信息的字段名称，默认：msg
            countName: 'count',     //数据总数的字段名称，默认：count
            dataName: 'data',       //数据列表的字段名称，默认：data
        },                          

        //数据渲染完的回调
        done: function (res, curr, count) {
            //res：接口返回的信息
            //curr：当前页码
            //count：数据总量
        },

        //初始排序
        //initSort: {
        //    field: 'Id',    //排序字段，对应 cols 设定的各字段名
        //    type: null,     //排序方式  asc: 升序、desc: 降序、null: 默认排序
        //},

        //是否开启分页
        page: true,
        //每页数据量可选项,默认值：[10,20,30,40,50,70,80,90]
        //limits: [10, 20, 30, 40, 50, 70, 80, 90],
        limit: 10,
    });

    //监听工具条
    //注：tool是工具条事件名，test是table原始容器的属性 lay-filter="对应的值"
    table.on('tool(test)', function (obj) { 
        var data = obj.data; //获得当前行数据
        console.log(data);
        var layEvent = obj.event; //获得 lay-event 对应的值
        var tr = obj.tr; //获得当前行 tr 的DOM对象

        if (layEvent === 'detail') { //查看
            //do somehing
        } else if (layEvent === 'del') { //删除
            layer.confirm('真的删除行么', function (index) {
                obj.del(); //删除对应行（tr）的DOM结构，并更新缓存
                layer.close(index);
                //向服务端发送删除指令
            });
        } else if (layEvent === 'edit') { //编辑
            //do something

            //同步更新缓存对应的值
            obj.update({
                username: '123'
                , title: 'xxx'
            });
        }
    });
});

















<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="WebAPI.index" %>


<!DOCTYPE html>
<html lang="zh-cn">
<head>
    <meta charset="utf-8" />
    <title>test</title>
    <meta name="author" content="xiewg@cebserv.com" />
    <meta name="copyright" content="www.doyoe.com" />
    <script src="https://cdn.staticfile.org/vue/2.4.2/vue.min.js"></script>
    <script src="https://cdn.staticfile.org/vue-resource/1.5.1/vue-resource.min.js"></script>
    <script src="https://code.jquery.com/jquery-3.1.1.min.js"></script>
    <style>
        p ~ p {
            color: #f00;
        }
    </style>
</head>
<body>
    <div id="app">
        <ol>
            <li v-for="site in message">{{ site.name }}
            </li>
        </ol>
        <a>1213</a>1213
    </div>
    <div id="ap1p">

        <table>
            {{message}}
        </table>
        <button v-on:click="greet">get</button>
        <button v-on:click="postgreet">post</button>
    </div>

    <script type="text/javascript">
        //var books={[]};
        //{
        // [
        //  {"id":1,"author":"曹雪芹","name":"红楼梦","price":32},
        //  {"id":2,"author":"施耐庵","name":"水浒传","price":30},
        //  {"id":"3","author":"罗贯中","name":"三国演义","price":24},
        //  {"id":4,"author":"吴承恩","name":"西游记","price":20}
        //  ]
        //}
        new Vue({
            el: '#app',
            data: {
                message: [
                    { "id": 1, "author": "曹雪芹", "name": "红楼梦", "price": 32 },
                    { "id": 2, "author": "施耐庵", "name": "水浒传", "price": 30 },
                    { "id": 3, "author": "罗贯中", "name": "三国演义", "price": 24 },
                    { "id": 4, "author": "吴承恩", "name": "西游记", "price": 20 }
                ]
            }

        })
    </script>
</body>

</html>

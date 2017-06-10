$(function () {
    $(".rotate-con-zhen").click(function () {
        lottery()
    })
})
function drop() {
    $(".hidden_index").hide();
}

function lottery() {
    $.ajax({
        type: 'POST',
        url: "/Home/getCount",
        dataType: "json",
        async: false,
        cache: false,
        success: function (data) {
            if (data.datetype == 0) {
                $("#errormessage").html("请登录后在试");
                $(".hidden_index").show();
            }
            if (data.datetype == 2) {
                $("#errormessage").html("你已经抽过奖啦");
                $(".hidden_index").show();
            }
            if (data.datetype == 1) {
                var random = parseInt(data.da);//角度
                var p = data.info;//奖项
                $("#rotate").rotate({
                    duration: 5000,
                    angle: 0,
                    animateTo: 1800 - random,
                    easing: $.easing.easeOutSine,
                    callback: function () {
                        $("#errormessage").html("恭喜你获得" + p);
                        $(".hidden_index").show();
                    }
                })
            }
            if (data.datetype == 3) {
                $("#errormessage").html("系统错误");
                $(".hidden_index").show();
            }

        }
        , error: function (data) {
            console.log(data);
        }
    })
}

window.onload = function () {
    var speed = 1000;
    var demo = document.getElementById("winner_big");
    var demo1 = document.getElementById("winner_box");
    var i = 0;
    function Roll() {
        if ($(".winner_box ul").length > 8) {
            $(".winner_box").append("<ul style='display:none'><li>12:12:11</li><li>就是这样子的" + i + "</li><li>获得了" + i + "万银子</li></ul>");
            $(".winner_box ul:last").fadeIn(800, function () {
                $(".winner_box").animate({ marginTop: "-0.4rem" }, 800, function () {
                    $(".winner_box ul:first").remove();
                    $(".winner_box").animate({ marginTop: "0rem" }, 0);
                });
            });
           
        }
        if ($(".winner_box ul").length <= 8) {
            $(".winner_box").append("<ul style='display:none'><li>12:12:1" + i + "</li><li>就是这样子的" + i + "</li><li>获得了" + i + "万银子</li></ul>");
            $(".winner_box ul:last").fadeIn(800);
        }
        i++;
    }
    var myMar = setInterval(Roll, speed);
}

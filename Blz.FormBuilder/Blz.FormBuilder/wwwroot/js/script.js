var FormDesignerJs = FormDesignerJs || {};

var hexDigits = new Array
    ("0", "1", "2", "3", "4", "5", "6", "7", "8", "9", "a", "b", "c", "d", "e", "f");

//Function to convert rgb color to hex format
function rgb2hex(rgb) {
    rgb = rgb.match(/^rgb\((\d+),\s*(\d+),\s*(\d+)\)$/);
    return "#" + hex(rgb[1]) + hex(rgb[2]) + hex(rgb[3]);
}

function hex(x) {
    return isNaN(x) ? "00" : hexDigits[(x - x % 16) / 16] + hexDigits[x % 16];
}



FormDesignerJs.getEntryText = (element) => {
    console.log("in script", element);
    var text = $(element).text();
    console.log("text entry=", text)
    return text;
}

FormDesignerJs.setControlProperty = (index) => {
    var element = $(".formcontrol-container input")[index];
    var name = $(element).val();
    var bgcolor = $(element).css("background-color");
    bgcolor = rgb2hex(bgcolor);
    console.log(bgcolor);
    $("#design_name").val(name);
    $("#design_bg").val(bgcolor);
    $(".current-control-index").text(index)
}

FormDesignerJs.removeHighlightCss = (index) => {
    for (var i = 0; i < $("input").length; i++) {
        var element = $("input")[i]
        var parent_ele = $(element).parent();
        if (i === index) {
            $(element).addClass("HighlightInput");
            $(parent_ele).addClass("HighlightBg");
            continue;
        }
        if ($(element).hasClass("HighlightInput")) {
            $(element).removeClass("HighlightInput");
        }
        if ($(parent_ele).hasClass("HighlightBg")) {
            $(parent_ele).removeClass("HighlightBg");
        }
        
    }
}

FormDesignerJs.setStyleFromProperty = (name, bgcolor) => {
    var chooseIndex = $(".current-control-index").text();
    console.log("chooseIndex=", chooseIndex);
    var element = $(".control-div input")[chooseIndex];
    $(element).val(name);
    var str_var = "background-color:" + bgcolor + ";";
    $(element).css("background-color", bgcolor);
    element = $(".control-div label")[chooseIndex];
    $(element).text(name);
}

FormDesignerJs.getPropertyIndex = function (dotNetObject) {
    var chooseIndex = $(".current-control-index").text();
    var name = $("#design_name").val();
    var bgcolor = $("#design_bg").val();
    dotNetObject.invokeMethodAsync('UpdateAllControls', chooseIndex.toString(), name, bgcolor);
}
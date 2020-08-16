var FormDesignerJs = FormDesignerJs || {};
FormDesignerJs.getEntryText = (element) => {
    console.log("in script", element);
    var text = $(element).text();
    console.log("text entry=", text)
    return text;
}

FormDesignerJs.setControlProperty = (entryname, bgcolor) => {
    $("#design_name").val(entryname);
    $("#design_bg").val(bgcolor);
}

FormDesignerJs.removeHighlightCss = (index) => {
    console.log("hello world", index)
    for (var i = 0; i < $("input").length; i++) {
        var element = $("input")[i]
        if (i === index) {
            $(element).addClass("HighlightInput");
            continue;
        }
        if ($(element).hasClass("HighlightInput")) {
            $(element).removeClass("HighlightInput");
        }
    }
}
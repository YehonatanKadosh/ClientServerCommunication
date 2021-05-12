$(() => {
    $("#Add").click(() => {
        if ($("#cityName").val()) {
            $.ajax({
                url: "http://localhost:2048/api/city",
                type: "POST",
                data: JSON.stringify({ Name:$("#cityName").val()}),
                contentType: "application/json;charset=utf-8"
            }).done((response) => {
                $("#myDiv").text("City added successfully");
            }).fail(() => {
                alert("An error has occurred");
            });
        }
    });

    $("#Cities").click(() => {
        $.ajax({
            url: "http://localhost:2048/api/city",
            type: "Get"
        }).done((responseText) => {
            $("#myDiv").text(JSON.stringify(responseText));
        }).fail(() => {
            alert("An error has occurred");
        });
    });
});
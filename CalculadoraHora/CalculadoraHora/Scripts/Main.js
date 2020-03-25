function calculate() {

    let total = document.getElementById("nmbTotal").value;
    let hourDay = document.getElementById("nmbHourday").value;
    let daysWeek = document.getElementById("nmbDaysWeek").value;
    let vacation = document.getElementById("nmbVacation").value;

    if (total === "" || hourDay === "" || daysWeek === "" || vacation === "") {
        alert("Preencha todos os campos");
    }
    else {
        let result = (total / (daysWeek * 4 * hourDay)) + ((vacation * daysWeek * hourDay));
        return console.log(result);
    }

}

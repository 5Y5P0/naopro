
// Cookie Compliancy BEGIN
function GetCookie(name) {
	let arg = name + "=";
	let alen = arg.length;
	let clen = document.cookie.length;
	let i = 0;
	while (i < clen) {
		let j = i + alen;
		if (document.cookie.substring(i, j) == arg)
			return "here";
		i = document.cookie.indexOf(" ", i) + 1;
		if (i == 0) break;
	}
	return null;
}

function testFirstCookie() {

		var visit = GetCookie(cookieAcceptedName);

		if (visit == null) {
			$("#myCookieConsent").fadeIn(400);	// Show warning
		} else {
			// Already accepted
		}

}

$(document).ready(function () {

	$("#cookieButton").click(function () {

		let date = new Date();
		let expire = new Date(date.setMonth(date.getMonth() + cookieMonthLife));

		document.cookie = cookieAcceptedName.concat("=here; expires=" + expire + ";path=/");

		$("#myCookieConsent").hide(400);

	});

	testFirstCookie();

});
// Cookie Compliancy END
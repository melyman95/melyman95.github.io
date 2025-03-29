document.getElementById("fetchButton").addEventListener("click", function () {
    let query = document.getElementById("fetchInput").value.trim();

    if (query) {
        // Redirecting to a search page with the query as a URL parameter
        window.location.href = "/Search?query=" + encodeURIComponent(query);
    } else {
        alert("Please enter a search term.");
    }
});

function isStringEmpty(value) {
    return value === undefined || value === null || value === "";
}

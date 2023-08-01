var apiUrl = "https://api.quotable.io/random";
const quoteText = document.querySelector(".quote");
const authorName = document.querySelector(".author .name");
const quoteBtn = document.querySelector(".button");
const copyBtn = document.querySelector(".copy");
const tweetBtn = document.querySelector(".tweet");
async function randomQuote(jsonData) {
    const response = await fetch(apiUrl);
    var data = await response.json();
    console.log(data);
    quoteText.innerHTML = data.content;
    authorName.innerHTML = data.author;
}
quoteBtn.addEventListener("click", randomQuote);
copyBtn.addEventListener("click", () => {
    navigator.clipboard.writeText(quoteText.innerHTML);
})
tweetBtn.addEventListener("click", () => {
    let tweetUrl = 'https://twitter.com/intent/tweet?hashtags=YazýlýmPark&text=' + quoteText.innerHTML;
    window.open(tweetUrl, "_blank");
})
 

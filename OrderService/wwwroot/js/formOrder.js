const btn = document.getElementById("addOrderBtn");
const formCreate = document.querySelector("div.cm-modal");

const closeFormBtn = document.querySelectorAll('[aria-label="Close"]');

btn.onclick = function () {
    formCreate.classList.add("is-open");
}

closeFormBtn[0].onclick = function () {
    formCreate.classList.remove("is-open");
}
const hamburgerMenu = document.querySelector(".hamburger-menu");
const offScreenMenu = document.querySelector(".off-screen-menu");

hamburgerMenu.addEventListener("click", () => {
  hamburgerMenu.classList.toggle("active");
  offScreenMenu.classList.toggle("active");
});

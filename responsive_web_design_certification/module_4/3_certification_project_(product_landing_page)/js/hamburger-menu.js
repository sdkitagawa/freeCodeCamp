/*
    * @Author: Douglas Kitagawa <dkitagawa>
    *
    * @Date: 04-08-2024
    *
    * @File: hamburger-menu.js
    *
    * @Brief: Set the state of two classes to active
    *
    * @Last modified by: dkitagawa
    *
    * @Last modified time: 04-08-2024
    *
    * TERMS OF USE - hamburger-menu
    *
    * Open source under the BSD License. 
    *
    * Copyright © 2024 Douglas Kitagawa
    * All rights reserved.
    *
    * Redistribution and use in source and binary forms, with or without modification, 
    * are permitted provided that the following conditions are met:
    *
    * Redistributions of source code must retain the above copyright notice, this list of 
    * conditions and the following disclaimer.
    * Redistributions in binary form must reproduce the above copyright notice, this list 
    * of conditions and the following disclaimer in the documentation and/or other materials 
    * provided with the distribution.
    *
    * Neither the name of the author nor the names of contributors may be used to endorse 
    * or promote products derived from this software without specific prior written permission.
*/
const hamburgerMenu = document.querySelector(".hamburger-menu");
const offScreenMenu = document.querySelector(".off-screen-menu");

hamburgerMenu.addEventListener("click", () => {
  hamburgerMenu.classList.toggle("active");
  offScreenMenu.classList.toggle("active");
});

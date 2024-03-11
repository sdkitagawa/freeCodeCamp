/*
    * @Author: Douglas Kitagawa <dkitagawa>
    *
    * @Date: 02-28-2024
    *
    * @File: key-events.js
    *
    * @Brief: Set and check whether key are being pressed or not.
    *
    * @Last modified by: dkitagawa
    *
    * @Last modified time: 02-28-2024
    *
    * @return String
    *
    * TERMS OF USE - Key Events
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

document.addEventListener("keydown", (keyboardEvent) => {

    [...document.querySelectorAll(`[data-hotkey]`)].forEach(elem => {
          const combineKey = elem.dataset.hotkey.split("+")
          // Checking the matching of the Keys
          for (let userKeyStr of combineKey) {
            // Define here the trigger keys that you want to use for your Data-Hotkey
            let firstKey = "CTRL";
            let secondKey = "ALT";
            let thirdKey = "SHIFT";
            // Transforming the Key String in a Uppercase string
            userKeyStr = userKeyStr.toUpperCase()
            // Checks the if the number of elements in my String is greater than 1
            if (userKeyStr.length > 1) {
                // Checking if the key string match the name "CTRL" and then checking if it is really the CTRL Key
                if (userKeyStr === firstKey && keyboardEvent.ctrlKey) {
                    continue
                }
                // Checking if the key string match the name "ALT" and then checking if it is really the SHIFT Key
                if (userKeyStr === secondKey && keyboardEvent.altKey) {
                    continue
                }
                // Checking if the key string match the name "SHIFT" and then checking if it is really the ALT Key
                if (userKeyStr === thirdKey && keyboardEvent.shiftKey) {
                    continue
                }
            }
            // Checks if the pressed key is not present within my string (userKeyStr), and if this condition is met, the script as a whole is ignored.
            if (keyboardEvent.key.toUpperCase() !== userKeyStr) {
                return
            }
        }
        /*
          "preventDefault": This will keep the Default Keybindings safe.
          For example: `CTRL + W` will close tabs on Windows Browsers.
        */
        keyboardEvent.preventDefault() 
        elem.click()
      })
    })
$(function(){
	var gallery = $('.gallery a').simpleLightbox();
});

/*
*******************************************************
Script 1: Email Verification
***********************************************************
*/
function emailVerification(myForm) {
	re = /^\w+([\.-]?\w+)*@\w+([\.-]?\w+)*(\.\w{2,3})+$/
	if (re.test(myForm.emailAddr.value)) {
		return true
	}
	alert("Invalid email address")
	myForm.emailAddr.focus()
	myForm.emailAddr.select()
	return false
}

/*
*******************************************************
Script 2: Slideshow
***********************************************************
*/
window.onload = function() {
	var imgs = document.getElementById('slideshow').children;
	interval = 10000;
	currentPic = 0;
	imgs[currentPic].style.webkitAnimation = 'fadey '+interval+'ms';
	imgs[currentPic].style.animation = 'fadey '+interval+'ms';
	var infiniteLoop = setInterval(function(){
		imgs[currentPic].removeAttribute('style');
		if ( currentPic == imgs.length - 1) {
			currentPic = 0;
		} else {
			currentPic++;
		}
	imgs[currentPic].style.webkitAnimation = 'fadey '+interval+'ms';
	imgs[currentPic].style.animation = 'fadey '+interval+'ms';
}, interval);
}

/*
*******************************************************************
Script 3: Browser Plugin Detection
******************************************************************
*/
function browserDetection() { 
	if(navigator.userAgent.indexOf("Chrome") != -1 ){
		alert('You are using: Chrome');
    }
    else if(navigator.userAgent.indexOf("Opera") != -1 ){
		alert('You are using: Opera');
    }
    else if(navigator.userAgent.indexOf("Firefox") != -1 ){
        alert('You are using: Firefox');
    }
    else if((navigator.userAgent.indexOf("MSIE") != -1 ) || (!!document.documentMode == true )){
      alert('You are using: IE'); 
    }  
    else{
       alert('You are using: unknown');
    }
}

/*
*******************************************************************
Script 4: New Window
******************************************************************
*/
function newWindow() {
    window.open("http://www.wwe.com");
}

/*
*******************************************************
Script 5: Dynamic Web Page Update
***********************************************************
*/
function timeDigtal(){
	var currentTime = new Date();
	var hours = currentTime.getHours();
	var minutes = currentTime.getMinutes();
	var seconds = currentTime.getSeconds();
    alert(hours + ":" + minutes + ":" + seconds);
}

/*
*******************************************************
Script 6: Dynamic Frame Update
***********************************************************
*/
function dynamicFrame() {
    var frames = window.frames;
    frames[1].location = "http://www.wwe.com/shows/wwenxt";
}

/*
/*****************************************************************
Script 7: Image Rollover
****************************************************************
*/
function changeImage() {
    var image = document.getElementById('myImage');
    if (image.src.match("classic")) {
        image.src = "images/about.png";
    } else {
        image.src = "images/classic.png";
    }
}

/*
/*****************************************************************
Script 8: Set Cookie and Return Cookie
****************************************************************
*/
function writeCookie(){
    if( document.myform.customer.value == "" ){
	    alert("Enter some value!");
        return;
    }
    cookievalue= escape(document.myform.customer.value) + ";";
    document.cookie="name=" + cookievalue;
    alert ("Setting Cookies : " + "name=" + cookievalue );
}
function readCookie(){
	alert ("name=" + cookievalue );
}
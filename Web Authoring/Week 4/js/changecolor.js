function changeColor()
	{
		var oldColor;
		oldColor = document.body.style.backgroundColor;
		var newColor = prompt('Enter a colour:');
		document.body.style.backgroundColor = newColor;
	}
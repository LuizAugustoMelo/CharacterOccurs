function check(){
	var str = document.getElementById("word").value;
	
	str = str.replace(/ /g, "");
	str = str.toLowerCase();
	
	if (str.length > 0)
	{
		var i;
		var chars;
		var count;
		var result = "";
		for (i = 0; i < str.length; i++)
		{
			if (i == 0)
			{
				chars = [str[i]];
				count = [str.split( new RegExp( str[i], "gi" ) ).length-1];
			}
			else if(chars.includes(str[i]) == false)
			{
				chars.push(str[i]);
				count.push(str.split( new RegExp( str[i], "gi" ) ).length-1);
			}
		}
		for(i = 0; i < chars.length; i++)
		{
			if (count[i] > 1)
			{
				result += chars[i] + " = " + count[i] + " "
			}
		}
		alert(result);
	}
};
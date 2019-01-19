//setup
var userchoice = 0;
var inputval = 0;
var outputval = 0
var cuptoquart = 0.25;
var cuptogallon = ".0625"
var gallontoquart = "4"
var gallontocup = "16"
var outputmeasue = string.Empty

//input
PUT "What value do you want to convert?"
GET inputvalue

PUT "How do you want to convert your value?"
PUT "1) cups to quarts"
PUT "2) cups to gallons"
PUT "3) gallons to quarts"
PUT "4) gallons to cups"
GET userchoice

//processing
if userchoice=1
    outputvalue = inputvalue* cuptoquart
    outputmeasue = " Quart(s)"
else if userchoice = 2
    outputvalue = inputvalue* cuptogallon
    outputmeasue = " Gallon(s)"
else if userchoice = 3
    outputvalue = inputvalue* gallontoquart
    outputmeasue = " Quart(s)"
else
    outputvalue = inputvalue* gallontocup
    outputmeasue = " Cup(s)"
 
//output
PUT "The answer is " + outputvalue + outputmeasue

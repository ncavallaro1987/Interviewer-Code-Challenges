// for ints 1-100 
// print "A" if divisible by 3, 
// "B" if divisible by 5, 
// "AB" if divisible by 3 and 5, 
// and just the int if none of the above. 
// Format as "1, 2, A, 4, B, A, 7, 8, A, B, 11, A, 13, 14, AB, 16, 17, ..."

//initialize variables to use for readability
let div3 = false
let div5 = false
let div15 = false

//using a string concat
    //initialize string
    let strMessage = ""
    for (let i = 1; i < 101; i++) {

        //add a comma to everything after the first item.
        //this could also be accomplished by checking if (i > 1), 
        //but since we're manipulating the string strMessage 
        // rather than the variable i, I thought it best to check the string
        if (strMessage.length != 0) {
            strMessage = strMessage + ", "
        }
        
        //assign variables to simplify switch
        div3 = (i % 3 == 0)
        div5 = (i % 5 == 0)
        div15 = (div3 && div5)

        //use a switch to avoid nested if statements
        switch (true) {
            case div15:
                strMessage = strMessage + "AB";
                break;
            case div5:
                strMessage = strMessage + "B";
                break;
            case div3:
                strMessage = strMessage + "A";
                break;
            default:
                strMessage = strMessage + i;
                break;
        }
    }

    //print the message
    console.log("The output of strMessage is:")
    console.log(strMessage);

    console.log("")
    console.log("")

//using a collection
    //initialize array
    let arrMessage = []
    for (let i = 1; i < 101; i++) {
        
        //assign variables to simplify switch
        div3 = (i % 3 == 0)
        div5 = (i % 5 == 0)
        div15 = (div3 && div5)

        //use a switch to avoid nested if statements
        switch (true) {
            case div15:
                arrMessage.push("AB");
                break;
            case div5:
                arrMessage.push("B");
                break;
            case div3:
                arrMessage.push("A");
                break;
            default:
                arrMessage.push(i);
                break;
        }
    }

    //print the message
    console.log("The output of arrMessage.join(', ') is:")
    console.log(arrMessage.join(', '));

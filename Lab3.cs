
//main start
string enjoymentLevel = GetEnjoymentLevel();
string stadium = GetStadiumRecommendation(enjoymentLevel);
string game = GetGameRecommendation(stadium);
DisplayStadiumDetails(stadium, game);
// main end





static string GetEnjoymentLevel(){            //prompts the user for the enjoyment lvl for the game they want to attend and returns the value
    System.Console.WriteLine("What is your enjoyment level of game you would like to attend?  Please rate out of Boring, Average, Fun, or Epic.");
    return System.Console.ReadLine();   
}

static string GetStadiumRecommendation(string enjoymentLevel){    //Determines the best stadium to attend based off the enjoyment lvl and returns it
    if ((enjoymentLevel == ("Boring")) || (enjoymentLevel == ("boring"))){
        return "Nayland Stadium";
    }
    else if ((enjoymentLevel == ("Average"))|| (enjoymentLevel == ("average"))){
        return "Jordan-Hare Stadium";
    }
    else if (enjoymentLevel == ("Fun")|| (enjoymentLevel == ("fun"))){
        return "Tiger Stadium";
    }
    else if ((enjoymentLevel == ("Epic")) || (enjoymentLevel == ("epic"))){
        return "Saban Field at Bryant-Denny Stadium";
    }
    else{
        return "Invalid";
    }
}

static string GetGameRecommendation(string stadium){       //determines the best 
    if (stadium == ("Nayland Stadium")){
        return "vs Kent State";
    }
    else if (stadium == ("Jordan-Hare Stadium")){
        return "vs Kentucky";
    }
    else if (stadium == ("Tiger Stadium")){
        return "vs Alabama";
    }
    else if (stadium == ("Saban Field at Bryant-Denny Stadium")){
        return "vs Auburn";
    }
    else{
        return "n/a";
    }
}

static void DisplayStadiumDetails(string stadium, string game){
    Console.Clear();
    if (stadium == ("Invalid")){
        System.Console.WriteLine("You have given an invlaid responce");
    }
    else{
        System.Console.WriteLine("You should go to " + stadium + " " + game);
    }
}


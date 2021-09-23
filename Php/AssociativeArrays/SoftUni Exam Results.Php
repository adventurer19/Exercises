//SoftUni Exam Results
//Judge statistics on the last Programing Fundamentals exam was not working correctly,
// so you have the task to take all the submissions and analyze them properly.
// You should collect all the submission and print the final results and statistics about each language
// that the participants submitted their solutions in.
//You will be receiving lines in the following format: "{username}-{language}-{points}" until you receive "exam finished".
// You should store each username and his submissions and points.
//You can receive a command to ban a user for cheating in the following format: "{username}-banned".
// In that case, you should remove the user from the contest, but preserve his submissions in the total count
// of submissions for each language.
//After receiving "exam finished" print each of the participants, ordered descending by their max points,
// then by username, in the following format:
//Results:
//{username} | {points}
//…
//After that print each language, used in the exam, ordered descending by total submission count and then by language name,
// in the following format:
//Submissions:
//{language} – {submissionsCount}
//…
//Input / Constraints
//Until you receive "exam finished" you will be receiving participant submissions in the following format: "{username}-{language}-{points}".
//You can receive a ban command -> "{username}-banned"
//The points of the participant will always be a valid integer in the range [0-100];
//Output
//Print the exam results for each participant, ordered descending by max points and then by username, in the following format:
//Results:
//{username} | {points}
//…
//After that print each language, ordered descending by total submissions and then by language name, in the following format:
//Submissions:
//{language} – {submissionsCount}
<?php
$one=[];
$two=[];
//one => key as courseName , values as submissionCounts;
//two key as personName ,values as Points;
while (($input=readline())!="exam finished") {
$args =explode('-',$input);
    $name = $args[0];
if($args[1]=='banned') {
    unset($two[$name]);
    continue;
}
$lang = $args[1];
$grade = $args[2];
key_exists($lang,$one) ? $one[$lang]++ : $one[$lang]=1;
key_exists($name,$two) ? ($two[$name]>$grade? : $two[$name]=$grade ) : $two[$name] = $grade;

}

ksort($two);
arsort($two);
ksort($one);
arsort($one);
resultPrint($two,$one);



function resultPrint(array $two, array $one): void
{
    echo 'Results:' . PHP_EOL;
    foreach ($two as $k => $v) {
        echo $k . ' | ' . $v . PHP_EOL;
    }
    echo 'Submissions:' . PHP_EOL;
    foreach ($one as $k => $v) {
        echo $k . ' - ' . $v . PHP_EOL;
    }
}




?>


var studentListController = demo.controller('studentListController', function ($scope) {
    var students = [
        {id:1, name:"Emre"},
        { id: 1, name: "Esra" },
        { id: 2, name: "Emel" },
        { id: 3, name: "Serdar" },
        { id: 4, name: "Zeynep" }
    ];

    $scope.students = students;

    $scope.addStudent = function () {
        var student = { id: 5, name: "New Student" };
        $scope.students.splice(1, 0, student);
    }
});
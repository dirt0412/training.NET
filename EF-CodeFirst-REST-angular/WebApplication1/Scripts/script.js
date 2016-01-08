function EmpCtrl($scope) {
    $scope.listaRezerwacji = [];    
    $scope.getRezerwacje = function () {        
        $.ajax({
            type: "GET",
            url: "api/Rezerwacje",
            data: "{}",
            contentType: "json; charset=utf-8",
            dataType: "json",
            success: function (msg) {
                //console.log(msg);
                $scope.listaRezerwacji = msg;
                $scope.$apply();                
            }
        });
    };     
}

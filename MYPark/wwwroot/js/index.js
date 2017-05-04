var M;
(function (M) {
    "use strict";
    var indexService = (function () {
        // constructor
        function indexService() {
        }
        //  methods
        indexService.prototype.park = function (carparkID, name, status) {
            this.postPark({
                CarparkID: carparkID,
                Name: name,
                Status: status
            });
        };

        indexService.prototype.unpark = function (carparkID, status) {
            this.postPark({
                CarparkID: carparkID,
                Status: status
            });
        };

        indexService.prototype.postPark = function (userCarpark) {
            $.post('/Carpark/Park', userCarpark);
        };

        return indexService;
    })();
    M.indexService = indexService;
})(M || (M = {}));
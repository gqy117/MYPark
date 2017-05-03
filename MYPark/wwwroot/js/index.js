var M;
(function (M) {
    "use strict";
    var indexService = (function () {
        // constructor
        function indexService() {
        }
        //  methods
        indexService.prototype.park = function (carparkID, name, status) {
            $.post('/Home/Park',
                {
                    CarparkID: carparkID,
                    Name: name,
                    Status: status
                },
                function (res) {
                    console.log(res);
            });
        };

        // inject
        return indexService;
    })();
    M.indexService = indexService;
})(M || (M = {}));
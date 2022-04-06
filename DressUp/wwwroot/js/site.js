
function AddToCart(type, id) {

    const obj = {
        objId: type+id,
        type: type,
        id: id
    };

    let localStorageArray = [];

    if (localStorage.getItem("Cart")) {
        localStorageArray = JSON.parse(localStorage.getItem("Cart"))
    }

    if (localStorageArray.filter(x => x.objId == obj.objId).length <= 0) {
        console.log(localStorageArray);
        localStorageArray.push(obj);
    }
   
    localStorage.setItem("Cart", JSON.stringify(localStorageArray))
}
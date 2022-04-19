//1
function  find_chain(g) {
    let x = g.length
    let found = []
    for(let i = 0; i < x; i++){
        let character1 = g[i]
        let flag = false
        for(let j = x-1; j > i; j--){
            let character2 = g[j]
            if(character1 == character2){
                flag = true
                break
            }
        }
        if(flag == false && found.find(element => element == character1) == undefined){
            return character1
        }      
        else
            found.push(character1)
    }
}
//3
function swap(arr, i, j) {
    let tmp = arr[i]
    arr[i] = arr[j]
    arr[j] = tmp
}
function partition(arr, l, h) {
    let i = l - 1
    for(let j = l; j <= h-1; j++){
        if(arr[j] < arr[h]){
            i++
            swap(arr,i,j)
        }
    }
    swap(arr,i+1,h)
    return i + 1
}
function quickSort(arr, l, h) {
    if(l < h){
        let partI = partition(arr,l,h)
        quickSort(arr,l,partI-1)
        quickSort(arr,partI+1,h)
    }
    return arr
}
//5
class vector{
    constructor(x,y,z){
        this.x = x
        this.y = y
        this.z = z
    }
    sum(vector2){
        let v3 = new vector(this.x + vector2.x, 
            this.y + vector2.y, 
            this.z + vector2.z)
        return v3
        
    }
    sub(vector2){
        let v3 = new vector(this.x - vector2.x, 
            this.y - vector2.y, 
            this.z - vector2.z)
        return  v3
    }
    magnitude(){ 
        let x = Math.sqrt(Math.pow(this.x,2) + Math.pow(this.y,2) + Math.pow(this.z,2))
        return x
    }
    unit(){
        let mag = this.magnitude()
        let v3 = new vector(this.x/mag, this.y/mag, this.z/mag)
        return v3
    }
    eMult(n){
        let v3 = new vector(this.x * n, this.y * n, this.z * n)
        return v3
    }
    dot(v2){
        return (this.x * v2.x + this.y * v2.y + this.z * v2.z)
    }
}
//7

function orthogonal(v1,v2){
    if(v1.dot(v2) == 0)
        return true
    else
        return false
}

//9
function factorize(n){
    let arr = []
    for(let i = 0; i <= n; i++){
        let x = n / i
        if(Number.isInteger(x))
            arr.push(i)
    }
    return arr
}

console.log(find_chain("abacddbec"))
console.log(find_chain("dhcbhdrctb"))
console.log(find_chain("lamjmlakibi"))
console.log(quickSort([1,4,2,6,5,8],0,5))
console.log(quickSort([7,2,78,3,1,8,3,5],0,7))
console.log(quickSort([9,1,8,4,6],0,4))

const v1 = new vector(1,2,3)
const v2 = new vector(4,5,6)
const v3 = new vector(3,4,0)
const v4 = new vector(-4,3,2)

console.log(v1.sum(v2))
console.log(v1.sum(v3))
console.log(v3.sum(v4))
console.log(v1.sub(v2))
console.log(v4.sub(v3))
console.log(v2.sub(v4))
console.log(v1.magnitude())
console.log(v2.magnitude())
console.log(v3.magnitude())
console.log(v1.unit())
console.log(v2.unit())
console.log(v3.unit())
console.log(v1.eMult(3))
console.log(v2.eMult(5))
console.log(v3.eMult(7))
console.log(orthogonal(v1,v2))
console.log(orthogonal(v2,v3))
console.log(orthogonal(v3,v4))
console.log(factorize(12))
console.log(factorize(654))
console.log(factorize(2308))


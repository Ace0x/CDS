function insertRow(){

}
function main(){
    
}
//Define the callback
//recieves an object
//In this case returns the mouse event object
function mouseMovement(event){
    const mouse_position = document.getElementById('mousePosition')
    mouse_position.innerHTML = `Posición del mouse: ${event.clientX} - ${event.clientY}`
}
function getFormvalue(event)
{  
    const fname = document.getElementById('fname').value
    const lname = document.getElementById('lname').value
    const log = document.getElementById('log')
    log.textContent = `${fname}  ${lname} `
    event.preventDefault()
}
function insertRow(){
    const t = document.getElementById('sampleTable')
    const rowi = t.rows.length
    const cli = t.rows[0].cells.length
    const row = t.insertRow(rowi)

    for(let i = 0; i < cli;i++){
        let cl = row.insertCell(i)
        cl.innerHTML = `Row ${rowi} column ${i + 1}`
    }
}

function insertColumn(){
    const t = document.getElementById('sampleTable')
    const rowi = t.rows.length
    const cli = t.rows[0].cells.length

    for(let i = 0; i < rowi;i++){

       let cl = t.rows[i].insertCell(cli)
       cl.innerHTML = `Row ${rowi} column ${i + 1}`
    }
}

function changeContent(){
    const rowp = document.getElementById('rowp').value
    const colp = document.getElementById('colp').value
    const t = document.getElementById('myTable')
    const content = document.getElementById('content').value
    t.rows[rowp-1].cells[colp-1].innerHTML = `${content}`
}

function removeColor(){
    const color = document.getElementById('removeC').value
    const select = document.getElementById('colorSelect')
    for(let i = 0; i < select.length; i++){
        if(select.options[i].value == color){
            select.remove(i)
        }
    }
}
function addColor(){
    const color = document.getElementById('addC').value
    const select = document.getElementById('colorSelect')
    select.add(new Option(color))
}
function catSize(){
    let cat = document.getElementById('cat')
    const r1 = (Math.floor(Math.random() * 8) + 3) * 100
    const r2 = (Math.floor(Math.random() * 8) + 3) * 100
    cat.src = `http://placekitten.com/${r1}/${r2}`
    cat.style.width = `${r1}px`
    cat.style.height = `${r2}px`
    cat.addEventListener('mousemove', catSize)

}
//Register the event
document.addEventListener('mousemove', mouseMovement)

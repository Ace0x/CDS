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
    const select = document.getElementById('colorSelect')
    select.remove(option)
}
//Register the event
document.addEventListener('mousemove', mouseMovement)

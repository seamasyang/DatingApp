import { Component, OnInit } from '@angular/core';
import{HttpClient} from '@angular/common/http';

@Component({
  selector: 'app-person',
  templateUrl: './person.component.html',
  styleUrls: ['./person.component.css']
})
export class PersonComponent implements OnInit {

  persons:any;

  constructor(private http:HttpClient) 
  { 

  }

  ngOnInit() {
    this.getPersons();
  }

  getPersons(){
    this.http.get('http://localhost:5000/api/person').subscribe(response=>{
      this.persons = response;
    }, error=>{
      console.log(error);
    })
  }

}

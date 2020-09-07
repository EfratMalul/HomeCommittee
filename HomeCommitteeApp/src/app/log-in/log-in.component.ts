import { Component, OnInit } from '@angular/core';
import {FormControl, Validators, FormGroup} from '@angular/forms';
import { UserService } from '../service/user.service';

@Component({
  selector: 'app-log-in',
  templateUrl: './log-in.component.html',
  styleUrls: ['./log-in.component.scss']
})
export class LogInComponent implements OnInit {
  
  email = new FormControl('', [Validators.required, Validators.email]);

  getErrorMessage() {
    if (this.email.hasError('required')) {
      return 'You must enter a value';
    }

    return this.email.hasError('email') ? 'Not a valid email' : '';
  }

  fromLogin:FormGroup;
  constructor(private user:UserService) {

      var name=this.fromLogin.value.name;
       var password=this.fromLogin.value.password;

   }
   onSubmit(){
    this.user.getUserByPasssword(this.fromLogin.value.name,this.fromLogin.value.password);
   }

  ngOnInit(): void {
   
  }

}

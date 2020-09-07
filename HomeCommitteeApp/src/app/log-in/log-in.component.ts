import { Component, OnInit } from '@angular/core';
import {FormControl, Validators} from '@angular/forms';
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
  constructor(private user:UserService) { }

  ngOnInit(): void {
    this.user.getUserById()

  }

}

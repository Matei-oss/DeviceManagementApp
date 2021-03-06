import { HttpClient } from '@angular/common/http';
import { Component, OnInit } from '@angular/core';
import { Validators, FormBuilder, FormControl, FormGroup } from '@angular/forms';
import { Router } from '@angular/router';
import { LoginService } from 'src/app/shared/services/login.service';

@Component({
  selector: 'app-login-page',
  templateUrl: './login-page.component.html',
  styleUrls: ['./login-page.component.scss']
})
export class LoginPageComponent implements OnInit {

  form: FormGroup;
  constructor(private readonly fb: FormBuilder, private loginService: LoginService, private router: Router ) {
    this.form = this.fb.group({
      username: ['', Validators.required],
      password: ['', Validators.required]
    });
   }

  submitForm(){
    if (this.form.valid){
      this.loginService.login$(this.form.getRawValue().username, this.form.getRawValue().password).subscribe((value) => {
        this.loginService.setUserToken(value);
        this.router.navigate(['/device']);
      });
    } else {
      console.log('There is a problem with the form!');
    }
  }
  ngOnInit(): void {
  }

}

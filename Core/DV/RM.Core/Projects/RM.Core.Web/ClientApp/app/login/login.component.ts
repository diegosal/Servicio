import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { routerTransition } from '../router.animations';
import { AuthenticationService } from '../shared';
import { User } from '../model';

@Component({
    selector: 'app-login',
    templateUrl: './login.component.html',
    styleUrls: ['./login.component.css'],
    animations: [routerTransition()]
})
export class LoginComponent implements OnInit {
    user: User;


    constructor(public router: Router, private authenticationService: AuthenticationService) {
        this.user = new User;
    }

    ngOnInit() {
    }

    onLoggedin() {
        this.user.Email = this.user.Email;
        this.user.PassWord = this.user.PassWord;

        this.authenticationService.LogInUser(this.user)
            .subscribe(
            data => {

                alert('EXITO');
                //this.router.navigate([this.returnUrl]);
            },
            error => {

                alert('FALLA');
                //this.alertService.error('Username or password is incorrect');
                //this.loading = false;
            });
    }

}

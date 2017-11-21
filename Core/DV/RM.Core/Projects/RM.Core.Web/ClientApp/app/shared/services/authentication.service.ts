import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
import { User, TokenUser } from '../../model';

@Injectable()
export class AuthenticationService  {

    private headers: Headers;
    private options: RequestOptions;


    constructor(private http: Http) {
        this.headers = new Headers({ 'Access-Control-Allow-Origin': '*' });
        this.options = new RequestOptions({ headers: this.headers });
    }



    LogInUser(user: User) {

        return this.http.post('/api/User/login', user, this.options)
            .map((response: Response) => {
                let user = response.json();
                if (user && user.token) {
                    localStorage.setItem('currentUser', JSON.stringify(user));
                }
            });
    }

    Create(user: User) {
        alert(user.Email);
        return this.http.post('/api/User/register', user, this.options)
            .map((response: Response) => { });
    }

    private jwt() {
        // create authorization header with jwt token
        //let currentUser = JSON.parse(localStorage.getItem('currentUser'));
        //if (currentUser && currentUser.token) {
        //    let headers = new Headers({ 'Authorization': 'Bearer ' + currentUser.token });
        //    return new RequestOptions({ headers: headers });
        //}
    }
}

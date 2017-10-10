import { Injectable } from '@angular/core';
import { Http, Headers, RequestOptions, Response } from '@angular/http';
import { User } from '../../model';

@Injectable()
export class UserService {

    private headers: Headers;
    private options: RequestOptions;

    private jwt() {
        // create authorization header with jwt token
        //let currentUser = JSON.parse(localStorage.getItem('currentUser'));
        //if (currentUser && currentUser.token) {
        //    let headers = new Headers({ 'Authorization': 'Bearer ' + currentUser.token });
        //    return new RequestOptions({ headers: headers });
        //}
    }
}

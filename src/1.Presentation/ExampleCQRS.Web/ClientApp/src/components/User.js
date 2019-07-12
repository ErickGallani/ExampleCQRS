import React, { Component } from 'react';
import axios from 'axios';
import { makeStyles } from '@material-ui/core/styles';
import Button from '@material-ui/core/Button';
import FormControl from '@material-ui/core/FormControl';
import InputLabel from '@material-ui/core/InputLabel';
import Input from '@material-ui/core/Input';
import Container from '@material-ui/core/Container';
import Grid from '@material-ui/core/Grid';
import { ToastContainer, toast } from 'react-toastify';
import 'react-toastify/dist/ReactToastify.css';

export class User extends Component {

    state = {
        firstName: '',
        lastName: '',
        email: '',
        birthDate: null,
        errors: null,
        success: false
    };

    onChangeHandler = (event) => {
        const targetValue = event.target.value;
        const targetName = event.target.name;

        return this.setState((prevState => ({
            ...prevState,
            [targetName]: targetValue
        })))
    };

    submitForm = (event) => {
        axios.post('api/User/Create', {
            ...this.state
        })
        .then((response) => {
            console.log(response);
        })
        .catch((error) => {
            error.response.data.Errors.forEach(error => {
                toast.error(error.Message, {
                    position: toast.POSITION.TOP_CENTER
                });
            });
        });
    };

    render() {
        return (
            <div>
                <ToastContainer/>
                <Container maxWidth="sm">
                    <h1>Insert user</h1>
                    <Grid container spacing={3}>
                        <Grid item xs={12}>
                            <FormControl>
                                <InputLabel htmlFor="firstName">First name</InputLabel>
                                <Input
                                    onChange={this.onChangeHandler}
                                    name="firstName"
                                    id="firstName"
                                    inputProps={{
                                        'aria-label': 'First name',
                                    }} />
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl>
                                <InputLabel htmlFor="lastName">Last name</InputLabel>
                                <Input
                                    onChange={this.onChangeHandler}
                                    name="lastName"
                                    id="lastName"
                                    inputProps={{
                                        'aria-label': 'Last name',
                                    }} />
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <FormControl>
                                <InputLabel htmlFor="email">Email address</InputLabel>
                                <Input
                                    onChange={this.onChangeHandler}
                                    name="email"
                                    id="email"
                                    inputProps={{
                                        'aria-label': 'Email',
                                    }} />
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <InputLabel htmlFor="birthDate" variant="standard">Birth date</InputLabel>
                            <FormControl>
                                <Input
                                    onChange={this.onChangeHandler}
                                    name="birthDate"
                                    id="birthDate"
                                    type="date"
                                    inputProps={{
                                        'aria-label': 'Birth date',
                                    }} />
                            </FormControl>
                        </Grid>
                        <Grid item xs={12}>
                            <Button onClick={this.submitForm}>Submit</Button>
                        </Grid>
                    </Grid>
                </Container>
            </div>
        );
    }
}

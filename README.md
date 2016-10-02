# ExceptionMsgConcatener
Exception Message Concatener allows to get all the Inner Exceptions Messages from an Exception. You can return a new Exception or just all messages combined in one string.

## Installation

1. Open the Nuget Package Manager Console
2. Install-Package ExceptionMsgConcatener
3. Or from the Nuget Package Manager search for ExceptionMsgConcatener and install it from there

## Usage

Example #1:
```javascript
var innerException = new Exception("There was another error");
var exception = new Exception("There was an error", innerException);

var newException = ExceptionMsgConcatener.ExceptionToException(exception);
Console.WriteLine(newException.Message);

// Outputs
// "There was an error, There was another error"
```

Example #2:
```javascript
var innerException = new Exception("There was another error");
var exception = new Exception("There was an error", innerException);

var newExceptionMessage = ExceptionMsgConcatener.ExceptionToString(exception);
Console.WriteLine(newExceptionMessage);

// Outputs
// "There was an error, There was another error"
```

## Contributing

1. Fork it!
2. Create your feature branch: `git checkout -b my-new-feature`
3. Commit your changes: `git commit -am 'Add some feature'`
4. Push to the branch: `git push origin my-new-feature`
5. Submit a pull request :D

## License

MIT License

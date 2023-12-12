package main

import (
	"fmt"
	"strings"
)

func main() {
	str := "a=2,t=5,c=3"

	var sb strings.Builder

	for _, c := range str {
		if c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' {
			sb.WriteRune(c)

		}
	}
	strLastIndex := len(sb.String())
	for _, c := range str {

		if c >= '0' && c <= '9' {
			Insert(&sb, strLastIndex, fmt.Sprintf("%c", c))
		}
	}

	result := sb.String()
	fmt.Println(result)
}

func Insert(b *strings.Builder, index int, str string) {
	s := b.String()
	b.Reset()
	b.WriteString(s[:index] + str + s[index:])
}

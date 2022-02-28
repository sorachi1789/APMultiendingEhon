using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScriptChange : MonoBehaviour
{
    private TextMeshProUGUI textbox_name;
    public GameObject textobject_name;
    public GameObject MainCam;
    MainARCam ItemChange;

    



    void Start()
    {
        ItemChange = MainCam.GetComponent<MainARCam>();
        textbox_name = textobject_name.GetComponent<TextMeshProUGUI>();
    }

    // Update is called once per frame
    void Update()
    {
        if (ItemChange.Page == 1)
        {
            //1page
            textbox_name.text = "むかしむかしある男が、泉のそばで\n木を切っていました。" ;
            ItemChange.next1_2 = 1;
        }
        if (ItemChange.Page == 2)
        {
            //1-2page
            if (ItemChange.next1_2 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen1_2 = 0;
            }
            if (ItemChange.next1_2==1)
            {
                textbox_name.text = "熱心に仕事をするあまり汗をかき、\n手が滑って持っていたオノを\n泉に落としてしまいました。";
                ItemChange.Gamen1_2 = 1;
                ItemChange.next2_1 = 1;
            }
        }
        if (ItemChange.Page == 3)
        {
            //2page
            if (ItemChange.next2_1 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen2_1 = 0;
            }
            if (ItemChange.next2_1 == 1)
            {
                if (ItemChange.Page2_1 == 0)
                {
                    textbox_name.text = "男は困ってしまい、途方にくれました。\nオノがないと仕事ができません。";
                    ItemChange.Gamen2_1 = 0;
                }
                if (ItemChange.Page2_1 == 1)
                {
                    textbox_name.text = "…すると泉の水面が光り、波立ち始めました。\n中から泉の精霊が出てきたではありませんか！" +
                    "泉の精霊はピカピカに光る金と銀のオノを\n見せ、男に問いかけます。";
                    ItemChange.next2_2 = 1;
                    ItemChange.Gamen2_1 = 1;
                }
            }
        }
        if (ItemChange.Page == 4)
        {
            //2-2page
            if (ItemChange.next2_2 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen2_1 = 0;
            }
            if (ItemChange.next2_2 == 1)
            {
                if (ItemChange.Page2_2 == 0)
                {
                    textbox_name.text = "「あなたが落としたのは、どちらのオノですか？」";
                    ItemChange.Gamen2_1 = 1;
                }
                if (ItemChange.Page2_2 == 1)
                {
                    textbox_name.text = "「ではこのオノですか？」\nと使い古されたオノを見せました。";
                    ItemChange.Gamen2_1 = 1;

                }
                if (ItemChange.Page2_2 == 2)
                {
                    textbox_name.text = "「まぁ、あなたは正直者ですね。」\n。精霊は感心し、オノを拾うだけでなく\n金と銀のオノもくれました。";
                    ItemChange.next3_1 = 1;
                    ItemChange.Gamen2_1 = 1;

                }
                if (ItemChange.ED == 1 && ItemChange.Page2_2 == 1)
                {
                    textbox_name.text = "「他にはないです。あとは自力で頑張ってください。」\n。といい、精霊は泉の中へ戻っていきました。";
                    ItemChange.Gamen2_1 = 0;

                }
                if (ItemChange.ED == 1 && ItemChange.Page2_2 == 0)
                {
                    textbox_name.text = "「あなたは嘘つきですね。オノは全てもらいます。」\nといい、精霊は泉の中へ戻っていきました。";
                    ItemChange.Gamen2_1 = 0;
                }
            }
        }
        if (ItemChange.Page == 5)
        {
            //3page
            if (ItemChange.next3_1 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen3_1 = 0;
            }
            if (ItemChange.next3_1 == 1)
            {
                textbox_name.text = "その様子を離れた物陰から見ていた男がいました。";
                ItemChange.next3_2 = 1;
                ItemChange.Gamen3_1 = 1;
            }
        }
        if (ItemChange.Page == 6)
        {
            //3-2page
            if (ItemChange.next3_2 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen3_2 = 0;
            }
            if (ItemChange.next3_2 == 1)
            {
                textbox_name.text = "その男は羨ましがり、「オレももらってこよう」と、\nさっそく泉へ向かう準備を始めました。";
                ItemChange.next4 = 1;
                ItemChange.Gamen3_2 = 1;
            }
        }
        if (ItemChange.Page == 7)
        {
            //4page
            if (ItemChange.next4 == 0)
            {
                textbox_name.text = "物語を進めよう。";
            }
            if (ItemChange.next4 == 1)
            {
                if (ItemChange.Page4 == 0)
                {
                    textbox_name.text = "「えっと投げ入れるものは…」";
                }
                if (ItemChange.Page4 == 1)
                {
                    textbox_name.text = "「えっと投げ入れるものは…」" +
                    "\nと、" + ItemChange.Throw + "を持って泉へ向かいました。";
                    ItemChange.next5_1 = 1;
                }
            }
        }
        if (ItemChange.Page == 8)
        {
            //5page
            if (ItemChange.next5_1 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen5_1 = 0;
            }
            if (ItemChange.next5_1 == 1)
            {
                if (ItemChange.Page2_1 == 0)
                {
                    textbox_name.text = "「よぉし、この" + ItemChange.Throw + "でオレももらうんだ！」\n男は泉へ放り投げます。";
                    ItemChange.Gamen5_1 = 0;
                }
                if (ItemChange.Page2_1 == 1)
                {
                    if (ItemChange.Throw == "オノ" || ItemChange.Throw == "ガチョウ" || ItemChange.Throw == "リンゴ")
                    {
                        textbox_name.text = "どっぼーん！！\n\nするとまた水面が光り、精霊が現れました。";
                        ItemChange.next5_2 = 1;
                        ItemChange.Gamen5_1 = 1;
                    }
                    if (ItemChange.Throw == "キュウリ")
                    {
                        textbox_name.text = "「よぉ、あんちゃん。差し入れあんがとさん！」\nと河童が現れました。" +
                           "\n\n河童はキュウリを食し、すぐに帰ってしまいました。";
                        ItemChange.ED = 1;
                        ItemChange.Gamen5_1 = 2;
                    }
                    if (ItemChange.Throw == "木")
                    {
                        textbox_name.text = "木はぷかぷか浮いています。\n「しまった！木は水に沈まないんだ！！」" +
                           "\n\n水面下で精霊は笑っていて男は恥ずかしくなりました。";
                        ItemChange.ED = 1;
                        ItemChange.Gamen5_1 = 3;
                    }
                    if (ItemChange.Throw == "石")
                    {
                        textbox_name.text = "石は水面をはね、反対の地面に落ちました。\n『水切り』ができた瞬間です。";
                        ItemChange.ED = 1;
                        ItemChange.Gamen5_1 = 4;
                    }
                }
            }
        }

           
        if (ItemChange.Page == 9)
        {
            //5-2page
            if (ItemChange.next5_2 == 0)
            {
                textbox_name.text = "物語を進めよう。";
                ItemChange.Gamen5_2 = 0;
            }
            if (ItemChange.next5_2 == 1)
            {
                if (ItemChange.Page5_2 == 0)
                {
                    textbox_name.text = "「あなたが落としたのは、どちらの" + ItemChange.Throw + "ですか？」\n精霊の問いに待ってましたとばかりに男は答えます。";
                    ItemChange.Gamen5_2 = 1;
                }
                if (ItemChange.Page5_2 == 1)
                {
                    textbox_name.text = "「ではこの" + ItemChange.Throw + "ですか？」\nと投げ込んだ" + ItemChange.Throw + "を見せました。";
                    ItemChange.Gamen5_2 = 1;

                }
                if (ItemChange.Page5_2 == 2)
                {
                    textbox_name.text = "「まぁ、あなたは正直者ですね。」\n精霊は感心し、全ての" + ItemChange.Throw + "をくれました。";
                    ItemChange.Gamen5_2 = 1;
                    ItemChange.ED = 1;

                }
                if (ItemChange.ED == 1 && ItemChange.Page5_2 == 1)
                {
                    textbox_name.text = "「他にはないです。あとは自力で頑張ってください。」\nといい、精霊は泉の中へ戻っていきました。";
                    ItemChange.Gamen5_2 = 0;

                }
                if (ItemChange.ED == 1 && ItemChange.Page5_2 == 0)
                {
                    textbox_name.text = "「あなたは嘘つきですね。" + ItemChange.Throw + "は全てもらいます。」\nといい、精霊は泉の中へ戻っていきました。";
                    ItemChange.Gamen5_2 = 0;
                }
            }
        }
        if (ItemChange.Page == 10)
        {
            //6page
            if (ItemChange.ED == 0)
            {
                textbox_name.text = "物語を進めよう";
                ItemChange.Gamen6 = 0;
            }
            if (ItemChange.ED == 1)
            {
                if (ItemChange.Page2_2 == 0)
                {
                    textbox_name.text = "男は何ももらえませんでした。\nそして嘘をついたことを後悔しましたとさ。";
                    ItemChange.Gamen6 = 4;
                }
                if (ItemChange.Page2_2 == 1)
                {
                    textbox_name.text = "男は何ももらえませんでした。\nそして優柔不断を後悔しましたとさ。";
                    ItemChange.Gamen6 = 4;
                }
                if (ItemChange.next5_2 == 1 && ItemChange.Page5_2 == 0)
                {
                    textbox_name.text = "男は何ももらえませんでした。\nそして嘘をついたことを後悔しましたとさ。";
                    ItemChange.Gamen6 = 1;
                }
                if (ItemChange.next5_2 == 1 && ItemChange.Page5_2 == 1)
                {
                    textbox_name.text = "男は何ももらえませんでした。\nそして優柔不断を後悔しましたとさ。";
                    ItemChange.Gamen6 = 1;
                }
                if (ItemChange.Gamen5_1 == 2)
                {
                    textbox_name.text = "河童ってホントにいるんだなぁ…";
                    ItemChange.Gamen6 = 1;
                }
                if (ItemChange.Gamen5_1 == 3)
                {
                    textbox_name.text = "彼は浮力というものを提唱し、後世に名を残しました。";
                    ItemChange.Gamen6 = 1;
                }
                if (ItemChange.Gamen5_1 == 4)
                {
                    textbox_name.text = "平たい石の方がよく跳ねるんだな…";
                    ItemChange.Gamen6 = 1;
                }
                if (ItemChange.next5_2 == 1 && ItemChange.Page5_2 ==2 && ItemChange.Throw =="オノ")
                {
                    textbox_name.text = "「けけけ、このオノを売って一儲けしてやるぜ」\n。嘘をついてもらったオノを売り、大金を得ました。" +
                    "\nそのお金すぐに底をつき、泉は枯れてしまいました。\n精霊はどこかであきれているでしょう。";
                    ItemChange.Gamen6 = 2;
                }
                if (ItemChange.next5_2 == 1 && ItemChange.Page5_2 == 2 && ItemChange.Throw == "リンゴ")
                {
                    textbox_name.text = "金のリンゴの味見をしてみました。\n金属の味が口に広がります。" +
                    "\n「金メダルもこんな味なんだろうな…」\nしみじみ思いました。";
                    ItemChange.Gamen6 = 3;
                }
                if (ItemChange.next5_2 == 1 && ItemChange.Page5_2 == 2 && ItemChange.Throw == "ガチョウ")
                {
                    textbox_name.text = "銀ののガチョウはエサがわからず育てられませんでした。\n金のガチョウは逃げてしまい、行方が分かりません" +
                    "\nいずれどこかのお話で出てくるかもしれませんね。";
                    ItemChange.Gamen6 = 1;
                }
            }
        }
    }

    
}

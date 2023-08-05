using System;
using Leopotam.EcsProto;
using Leopotam.EcsProto.QoL;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoProto{


class System266 : IProtoInitSystem, IProtoRunSystem{
 ProtoWorld _world = null;
 Aspect1 _aspect = null;
 ProtoIt _it;
 public void Init (IProtoSystems systems) {
  _world = systems.World ();
  _aspect = (Aspect1) _world.Aspect (typeof (Aspect1));
 _it = new ProtoIt (new [] {typeof(Component46),typeof(Component29),typeof(Component179),typeof(Component77) } );
  _it.Init (_world);
 }
 public void Run () {
  for (_it.Begin (); _it.Next ();) {
  var q = 0;
   if (_aspect.Component55Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component55Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component365Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component365Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component295Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component295Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
   if (_aspect.Component98Pool.Has(_it.Entity()))
   {
    q+=1;
    var component1 = _aspect.Component98Pool.Get(_it.Entity());
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

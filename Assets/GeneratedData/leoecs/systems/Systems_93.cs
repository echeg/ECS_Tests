using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System93 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component54,Component356,Component176> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component443>())
   {
    q+=1;
    var com = entity.Get<Component443>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component267>())
   {
    q+=1;
    var com = entity.Get<Component267>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component118>())
   {
    q+=1;
    var com = entity.Get<Component118>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component451>())
   {
    q+=1;
    var com = entity.Get<Component451>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

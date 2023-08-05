using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System223 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component9,Component293,Component16,Component70> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component147>())
   {
    q+=1;
    var com = entity.Get<Component147>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component66>())
   {
    q+=1;
    var com = entity.Get<Component66>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component168>())
   {
    q+=1;
    var com = entity.Get<Component168>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component258>())
   {
    q+=1;
    var com = entity.Get<Component258>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

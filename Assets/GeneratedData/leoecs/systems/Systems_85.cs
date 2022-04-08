using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System85 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component202,Component60,Component360,Component143> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component137>())
   {
    q+=1;
    var com = entity.Get<Component137>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component343>())
   {
    q+=1;
    var com = entity.Get<Component343>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component106>())
   {
    q+=1;
    var com = entity.Get<Component106>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component7>())
   {
    q+=1;
    var com = entity.Get<Component7>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System336 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component263,Component296,Component59,Component100> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component215>())
   {
    q+=1;
    var com = entity.Get<Component215>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component132>())
   {
    q+=1;
    var com = entity.Get<Component132>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component387>())
   {
    q+=1;
    var com = entity.Get<Component387>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component361>())
   {
    q+=1;
    var com = entity.Get<Component361>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

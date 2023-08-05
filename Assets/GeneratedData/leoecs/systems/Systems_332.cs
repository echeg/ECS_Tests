using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System332 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component57> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component167>())
   {
    q+=1;
    var com = entity.Get<Component167>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component441>())
   {
    q+=1;
    var com = entity.Get<Component441>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component358>())
   {
    q+=1;
    var com = entity.Get<Component358>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component435>())
   {
    q+=1;
    var com = entity.Get<Component435>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

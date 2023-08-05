using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System281 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component309,Component301,Component249,Component475> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component410>())
   {
    q+=1;
    var com = entity.Get<Component410>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component415>())
   {
    q+=1;
    var com = entity.Get<Component415>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component426>())
   {
    q+=1;
    var com = entity.Get<Component426>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component167>())
   {
    q+=1;
    var com = entity.Get<Component167>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

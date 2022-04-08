using System;
using Leopotam.Ecs;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcs{


class System0 : IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter<Component300> _filter = null;
 public void Run () {
  foreach (var i in _filter) {
   var q = 0;
   ref var entity = ref _filter.GetEntity (i);
   if (entity.Has<Component380>())
   {
    q+=1;
    var com = entity.Get<Component380>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component80>())
   {
    q+=1;
    var com = entity.Get<Component80>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component228>())
   {
    q+=1;
    var com = entity.Get<Component228>();
   }
   else
   {
    q-=1;
   }
   if (entity.Has<Component22>())
   {
    q+=1;
    var com = entity.Get<Component22>();
   }
   else
   {
    q-=1;
   }
  }
 }
}

}

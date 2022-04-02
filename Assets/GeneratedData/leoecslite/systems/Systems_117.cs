using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System117 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component121> _p1;
EcsPool<Component237> _p2;
EcsPool<Component79> _p3;
EcsPool<Component250> _p4;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component121>().Inc<Component237>().Inc<Component79>().Inc<Component250>().End();
   _p1 = _world.GetPool<Component121>();
   _p2 = _world.GetPool<Component237>();
   _p3 = _world.GetPool<Component79>();
   _p4 = _world.GetPool<Component250>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}

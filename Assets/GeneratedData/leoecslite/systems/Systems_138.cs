using System;
using Leopotam.EcsLite;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;
namespace EcsGenerator.LeoEcsLite{


class System138 : IEcsInitSystem, IEcsRunSystem{
 EcsWorld _world = null;
 EcsFilter _filter;
EcsPool<Component222> _p1;
EcsPool<Component73> _p2;
EcsPool<Component348> _p3;
 public void Init (EcsSystems systems) {
  _world = systems.GetWorld ();
  _filter = _world.Filter<Component222>().Inc<Component73>().Inc<Component348>().End();
   _p1 = _world.GetPool<Component222>();
   _p2 = _world.GetPool<Component73>();
   _p3 = _world.GetPool<Component348>();
 }
 public void Run (EcsSystems systems) {
  foreach (int entity in _filter) {
  var q = 0;
  }
 }
}

}
